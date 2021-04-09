using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace PlanetsGame.Controllers
{
    public class TermsController : BaseController
    {
        Models.TermsModel model;

        public TermsController()
        {
        }

        public Abstracts.IModel Model
        {
            get
            {
                model = new Models.TermsModel()
                {
                    Lang = Utils.DataSupplier.Self.Lang,
                    TermsText = Utils.DataSupplier.Self.GetText("TERMS_InfoText"),
                    LangImage = new BitmapImage(new Uri(string.Format("pack://application:,,,/PlanetsGame;component/Resources/{0}.png", Utils.DataSupplier.Self.LangNext.ToLower())))
                };
                return model;
            }
        }
    }
}
