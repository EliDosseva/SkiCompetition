using System.Windows.Forms;

namespace MyExample
{
    internal static class MyMessages
    {
        internal static DialogResult DisplayConfirmation(string msg)
        {
            return MessageBox.Show(msg, "SkiCompetition", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        internal static void DisplayInfo(string msg)
        {
           MessageBox.Show(msg, "SkiCompetition", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        internal static void DisplayError(string msg)
        {
            MessageBox.Show(msg, "SkiCompetition", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void DisplayWarning(string msg)
        {
            MessageBox.Show(msg, "SkiCompetition", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        internal static DialogResult Warning(string msg)
        {
            return MessageBox.Show(msg, "SkiCompetition", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
