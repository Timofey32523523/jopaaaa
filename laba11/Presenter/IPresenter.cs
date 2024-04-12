using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba11.Presenter
{
    public interface IPresenter
    {
        
        string name { get; set; }
        string brand { get; set; }
        string color { get; set; }
        string type { get; set; }
        int size { get; set; }
        double price { get; set; }
        string DelInfo { get; set; }    
        //это твои свойства, через которые общаются вью и презентер
}
}
