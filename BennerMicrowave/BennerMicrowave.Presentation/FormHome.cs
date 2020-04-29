using BennerMicrowave.Application.Services;
using BennerMicrowave.Domain.Entities;
using BennerMicrowave.Domain.Interfaces;
using System;
using System.Media;
using System.Windows.Forms;

namespace BennerMicrowave.Presentation
{
    public partial class FormHome : Form
    {
        private CookParams _params;
        private readonly ICookService _cookService;

        private readonly DateTime _today;
        private bool _canEdit = true;
        public FormHome()
        {
            InitializeComponent();
            _today = DateTime.Today.Date;
            _cookService = new CookService();
            _cookService.CookFractionTimeElapsedEventHandler += this.CookFractionElapsed_Listener;
            _cookService.CookEndEventHandler += this.CookEnded_Listener;
        }

        private void CookFractionElapsed_Listener(object sender, Domain.Events.CookFractionElapsedArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                this.txtFeedback.Text = e.Feedback;
                this.txtTime.Value = _today + e.TimeLeft;
                SystemSounds.Hand.Play();
            });
        }
        private void CookEnded_Listener(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                _canEdit = true;
                VerifyInputs();
            });
        }

        private void btnStart_Click(object sender, System.EventArgs e)
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
            txtPower.Text = CookParams.DefaultPower.ToString();
            txtTime.Value = _today + new TimeSpan(0, 0, CookParams.DefaultTimeSeconds);
            Start();
        }

        public void Start()
        {
            _params = new CookParams(
                Convert.ToInt32(txtPower.Text),
                txtTime.Value.TimeOfDay,
                txtFood.Text
            );

            if (!_params.IsValid)
            {
                MessageBox.Show(_params.ValidationMessage, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _canEdit = false;
            VerifyInputs();
            _cookService.Start(_params);
        }

        private void VerifyInputs()
        {
            txtTime.Enabled = _canEdit;
            txtPower.Enabled = _canEdit;
            txtFood.Enabled = _canEdit;
        }
    }
}
