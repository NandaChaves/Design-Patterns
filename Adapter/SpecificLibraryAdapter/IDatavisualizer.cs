using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificLibraryAdapter
{
    public interface IDatavisualizer
    {
        void DisplayGraph(string jsondata);
    }

    public class DataFormatAdapter : IDatavisualizer
    {
        private readonly AnalyticsLibrary _adaptee;
        public DataFormatAdapter(AnalyticsLibrary adaptee)
        {
           _adaptee = adaptee;
        }

        public void DisplayGraph(string jsondata)
        {
            CustomLibraryObject obj = GetObjFromJson(jsondata);
            _adaptee.DisplayGraph(obj);
        }

        public CustomLibraryObject GetObjFromJson(string jsondata)
        {
            //convert json data to library object
            return new CustomLibraryObject();
        }
    }
}
