using BennerMicrowave.Domain.Entities;
using BennerMicrowave.Domain.Services;
using BennerMicroWave.IoC;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BennerMicrowave.Presentation
{
    public partial class FormPrograms : Form
    {
        private readonly ICookProgramService _service;

        public FormPrograms()
        {
            InitializeComponent();
            _service = ServiceContainer.Get<ICookProgramService>();
            _service.ValidationFails += this.DomainValidation_Fail;
        }

        private void DomainValidation_Fail(object sender, Domain.Events.ValidationFailsEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                MessageBox.Show(e.Feedback, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (InvalidInputs())
            {
                MessageBox.Show("Informe os campos para salvar", "Atenção", MessageBoxButtons.OK);
                return;
            }

            var addResult = _service.Add(new CookProgram(
                txtName.Text,
                txtInstructions.Text,
                txtTime.Value.TimeOfDay,
                Convert.ToInt32(txtPower.Text),
                txtChar.Text[0],
                txtEntries.Text.Split(',').Select(c => c.Trim())
            ));

            if (addResult)
            {
                if (MessageBox.Show("Registro salvo com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private bool InvalidInputs()
        {
            return string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtChar.Text) ||
                string.IsNullOrEmpty(txtEntries.Text) ||
                string.IsNullOrEmpty(txtInstructions.Text) ||
                string.IsNullOrEmpty(txtChar.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
