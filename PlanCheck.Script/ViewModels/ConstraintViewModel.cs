using System.IO;

namespace PlanCheck
{
	public class ConstraintViewModel : ViewModelBase
    {
        public string ConstraintName { get; set; }
        public string ConstraintPath { get; set; }

        public ConstraintViewModel(string constraintPath)
        {
            ConstraintName = Path.GetFileNameWithoutExtension(constraintPath);
            ConstraintPath = constraintPath;
        }
    }
}
