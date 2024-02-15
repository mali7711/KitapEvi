namespace KitapEvi.Models
{
    public class KatagoriModel
    {
        public int KatagöriId { get; set; }
        public string KatagöriAdi { get; set; }
        List<KitapModel> KitapModels=new List<KitapModel>();
    }
}
