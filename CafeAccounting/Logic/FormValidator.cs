using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CafeAccounting.Logic
{
    public class FormValidator
    {
        private readonly Control _form;
        private readonly Button _submitButton;

        public FormValidator(Control form, Button submitButton)
        {
            _form = form;
            _submitButton = submitButton;

            AddEventsForFormControls(_form);
            ValidateForm();
        }

        private void AddEventsForFormControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.TextChanged += (s, e) => ValidateForm();
                }
                else if (control is NumericUpDown numericUpDown)
                {
                    numericUpDown.ValueChanged += (s, e) => ValidateForm();
                }

                if (control.HasChildren)
                {
                    AddEventsForFormControls(control);
                }
            }
        }

        private void ValidateForm()
        {
            _submitButton.Enabled = AreAllInputsValid(_form);
        }

        private bool AreAllInputsValid(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control.Tag?.Equals("NoValidation") == true)
                    continue;

                if (control is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                        return false;
                }
                else if (control is NumericUpDown numericUpDown)
                {
                    //if (numericUpDown.Value == 0)
                    //    return false;
                }

                if (control.HasChildren)
                {
                    if (!AreAllInputsValid(control))
                        return false;
                }
            }
            return true;
        }
    }
}
