using System;
using System.Windows.Forms;

namespace MedicalChestProject
{
    public interface IContext
    {
        MessageBox MessageBox { get; set; }
        Label ErrorLabel { get; set; }
        Label StatusLabel { get; set; }
        ToolStrip ToolStrip { get; set; }
        MenuStrip MenuStrip { get; set; }
        StatusStrip StatusStrip { get; set; }
        Panel UserControl { get; set; }
        DataGridView DataGridView { get; set; }
    }
}
