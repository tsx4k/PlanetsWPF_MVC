using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PlanetsGame.Models
{
    public class BaseModel : Abstracts.IModel
    {
        public string Lang;
        public ImageSource LangImage { get; set; }
    }
}
