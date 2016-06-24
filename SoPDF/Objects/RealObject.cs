using System.Text;

namespace SoPDF.Objects
{
    public class RealObject : NumObject
    {
        //private double Content { get; set; }

        public RealObject(double content)
        {
            Content = content;
        }

        public override byte[] ToBytes()
        {
            double content = double.Parse(base.Content.ToString());
            return Encoding.ASCII.GetBytes(content.ToString());
        }
    }
}
