namespace RoutePlanWebApi.Models
{
    public class LicenseFile
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Name { get; set; }
        public System.DateTime DateUploaded { get; set; }

        public virtual Driver Driver { get; set; }
    }
}
