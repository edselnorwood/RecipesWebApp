namespace RecipesWebApp.Services
{
    public class BasicImageService : IImageService
    {
        public string ContentType(IFormFile file)
        {
            if (file == null)
            {
                return null;
            }
            return file.ContentType;
        }

        public string DecodeImage(byte[] data, string type)
        {
            if (data == null || type == null)
            {
                return null;
            }
            return $"data:{type};base64,{Convert.ToBase64String(data)}";
        }

        public async Task<byte[]> EncodeImageAsync(IFormFile file)
        {
            if (file == null)
            {
                return null;
            }
            using var stream = new MemoryStream();
            await file.CopyToAsync(stream);
            return stream.ToArray();
        }

        public async Task<byte[]> EncodeImageAsync(string filename)
        {
            var file = $"{Directory.GetCurrentDirectory()}/wwwroot/img/{filename}";
            return await File.ReadAllBytesAsync(file);
        }

        public int Size(IFormFile file)
        {
            if (file == null)
            {
                return 0;
            }
            return Convert.ToInt32(file.Length);
        }
    }
}
