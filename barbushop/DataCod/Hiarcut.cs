namespace barbushop
{
    public class Hiarcut 
    {
        public string HiarNmae { get; set; }
        public string PicName { get; set; }
        public string Price { get; set; }

        public Hiarcut(string Hiarnmae, string Picname, string price)
        {

            this.HiarNmae = Hiarnmae;
            this.PicName = Picname;
            this.Price = price;
        }
    }
    
    
}