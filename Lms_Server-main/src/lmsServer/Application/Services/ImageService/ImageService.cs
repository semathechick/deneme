
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using static System.Net.Mime.MediaTypeNames;

namespace Application.Services.ImageService;
public class ImageService : ImageServiceBase
{
    private readonly Cloudinary cloudinary;
    public ImageService(IConfiguration config)
    {
        string cloudName = config.GetSection("CloudinarySettings:CloudName").Value;
        string apiKey = config.GetSection("CloudinarySettings:ApiKey").Value;
        string apiSecret = config.GetSection("CloudinarySettings:ApiSecret").Value;

        Account account = new Account(cloudName, apiKey, apiSecret);
        cloudinary = new Cloudinary(account);
        cloudinary.Api.Secure = true;

    }

    public override Task DeleteAsync(string imageUrl)
    {
        throw new NotImplementedException();
    }

    

    public override async Task<ImageUploadResult> UploadAsync(IFormFile image)
    {
        var uploadResult = new ImageUploadResult();
        if (image.Length > 0)
        {
            using var stream = image.OpenReadStream();
            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(image.FileName, stream),
                Transformation = new Transformation().Height(70).Width(80)
            };
            uploadResult = await cloudinary.UploadAsync(uploadParams);
        }
        return uploadResult;   
    }

    
}
