namespace ImageUploaderAPI.Model
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public DateTime UploadTime { get; set; }
    }

}
