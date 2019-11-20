using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CurriculumViewer.WebUI.Models.ViewModels
{
    public sealed class ListComponentFieldTypes
    {
        public static string Id = "Id";
        public static string Name = "Name";
        public static string Description = "Description";
        public static string FullName = "FullName";
    }

    public class ListComponentViewModel
    {
        /// <summary>
        /// Items
        /// </summary>
        public IEnumerable<object> Items { get; set; } = new List<object>();

        /// <summary>
        /// What thing to show
        /// </summary>
        public string Expression { get; set; }
    }
}
