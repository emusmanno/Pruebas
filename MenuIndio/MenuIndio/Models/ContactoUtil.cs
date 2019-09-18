namespace MenuIndio.Views
{
    internal class ContactoUtil
    {
        public ContactoUtil(string pName, string pNum, string pImage)
        {
            Name = pName;
            Num = pNum;
            imgsource = pImage;

        }

        public string Name { get; set; }
        public string Num { get; set; }
        public string imgsource { get; set; }
    }
}