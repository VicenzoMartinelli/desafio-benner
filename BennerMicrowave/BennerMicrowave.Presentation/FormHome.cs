using BennerMicrowave.Domain.Entities;
using BennerMicrowave.Domain.Events;
using BennerMicrowave.Domain.Interfaces;
using BennerMicrowave.Domain.Services;
using BennerMicroWave.IoC;
using System;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace BennerMicrowave.Presentation
{
    public partial class FormHome : Form
    {
        private CookParams _params;
        private readonly ICookService _cookService;
        private readonly ICookProgramService _cookProgramService;

        private readonly DateTime _today;
        private bool _cooking = false;
        private bool _paused = false;

        public FormHome()
        {
            InitializeComponent();
            _today = DateTime.Today.Date;

            // Resolve dependencies
            _cookService = ServiceContainer.Get<ICookService>();
            _cookProgramService = ServiceContainer.Get<ICookProgramService>();

            // Register listeners
            _cookService.CookFractionTimeElapsedEventHandler += this.CookFractionElapsed_Listener;
            _cookService.CookFinishedEventHandler += this.CookFinished_Listener;
        }

        private void CookFractionElapsed_Listener(object sender, Domain.Events.CookFractionElapsedArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                WriteFeedback(e.Feedback);
                this.txtTime.Value = _today + e.TimeLeft;
                SystemSounds.Hand.Play();
            });
        }
        private void CookFinished_Listener(object sender, CookFinishedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                txtFeedback.AppendText("\n" + e.Feedback);

                _cooking = false;
                VerifyInputs();
            });
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (InvalidInputs())
            {
                MessageBox.Show("Informe os dados de entrada para iniciar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Start();
        }

        private bool InvalidInputs()
        {
            return string.IsNullOrEmpty(txtPower.Text) || string.IsNullOrEmpty(txtTime.Text);
        }

        private void btnQuickStart_Click(object sender, EventArgs e)
        {
            SetDefaultParams();
            Start();
        }

        private void SetDefaultParams()
        {
            txtPower.Text = CookParams.DefaultPower.ToString();
            txtTime.Value = _today + new TimeSpan(0, 0, CookParams.DefaultTimeSeconds);
        }

        public void Start(char cookChar = '.')
        {
            CleanFeedback();
            _params = new CookParams(
                Convert.ToInt32(txtPower.Text),
                txtTime.Value.TimeOfDay,
                txtFood.Text,
                cookChar
            );

            if (!_params.IsValid)
            {
                MessageBox.Show(_params.ValidationMessage, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _cooking = true;
            _paused = false;

            VerifyInputs();
            _cookService.Start(_params);
        }

        private void VerifyInputs()
        {
            btnPause.Text = _paused ? "Continuar" : "Pausar";
            btnPause.Visible = _cooking;
            btnStop.Visible = _cooking;

            txtTime.Enabled = !_cooking;
            txtPower.Enabled = !_cooking;
            txtFood.Enabled = !_cooking;
        }
        private void CleanFeedback()
        {
            WriteFeedback(null);
        }

        private void WriteFeedback(string text)
        {
            txtFeedback.Text = text;

            if (chk.Checked && File.Exists(txtPath.Text))
            {
                File.WriteAllText(txtPath.Text, text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WriteFeedback(string.Join($"{Environment.NewLine}{Environment.NewLine}", _cookProgramService.GetCookProgramsByEntry(txtFood.Text).Select(c => c.ToString())));
        }

        private void btnSearchPrograms_Click(object sender, EventArgs e)
        {
            WriteFeedback(string.Join($"{Environment.NewLine}{Environment.NewLine}", _cookProgramService.GetCookPrograms().Select(c => c.ToString())));
        }

        private void btnNewProgram_Click(object sender, EventArgs e)
        {
            new FormPrograms
            {
                StartPosition = FormStartPosition.CenterParent
            }.ShowDialog();
        }

        private void btnStartWithProgram_Click(object sender, EventArgs e)
        {
            var formSelect = new FormSelectProgram
            {
                Food = txtFood.Text,
                StartPosition = FormStartPosition.CenterParent
            };

            formSelect.ShowDialog();

            if (formSelect.CookProgram != null)
            {
                var cookProgram = formSelect.CookProgram;

                txtPower.Text = cookProgram.Power.ToString();
                txtTime.Value = _today + cookProgram.Time;

                Start(cookProgram.CookCharacter);
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (_cooking)
            {
                if (_paused)
                {
                    _cookService.Continue();
                    _paused = false;
                }
                else
                {
                    _cookService.Pause();
                    _paused = true;
                }

                VerifyInputs();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_cooking)
            {
                _cookService.Stop();
                _cooking = false;

                SetDefaultParams();
                CleanFeedback();
                VerifyInputs();
            }
        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            txtPath.Visible = chk.Checked;
        }
    }
}
