using BennerMicrowave.Domain.Entities;
using BennerMicrowave.Domain.Services;
using BennerMicroWave.IoC;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BennerMicrowave.Presentation
{
    public partial class FormSelectProgram : Form
    {
        private readonly ICookProgramService _programService;

        public CookProgram CookProgram { get; set; }
        public string Food { get; set; }

        public FormSelectProgram()
        {
            InitializeComponent();

            _programService = ServiceContainer.Get<ICookProgramService>();

            cmbPrograms.Items.AddRange(_programService.GetCookPrograms().ToArray());
            cmbPrograms.DisplayMember = "Name";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var selected = cmbPrograms.SelectedItem as CookProgram;

            if (selected != null)
            {
                if (!selected.AcceptEntry(Food))
                {
                    MessageBox.Show("Entrada não valida para esse programa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CookProgram = selected;
                this.Close();
            }
        }
    }
}
