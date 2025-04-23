using System.Windows.Forms;

namespace WindowsFormsApp1.Common {
    public enum ChildControlStatus {
        Minimized,
        Maximized
    }

    public class ChildControlInfo {
        public Control ControlInstance { get; } 
        public ChildControlStatus Status { get; set; }
        public Control OriginalParent { get; } 
        public DockStyle OriginalDockStyle { get; } 

        public ChildControlInfo(Control control, Control parent, DockStyle originalDock)
        {
            ControlInstance = control;
            Status = ChildControlStatus.Minimized; 
            OriginalParent = parent;
            OriginalDockStyle = originalDock;
        }
    }
}