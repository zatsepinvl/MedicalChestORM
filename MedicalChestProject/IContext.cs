using System;
using System.Windows.Forms;

namespace MedicalChestProject
{
    public interface IContext
    {
        Label ErrorLabel { get; set; }
        MenuStrip MenuStrip { get; set; }
        StatusStrip StatusStrip { get; set; }
        Panel UserControl { get; set; }
        DataGridView DataGridView { get; set; }
    }
}
