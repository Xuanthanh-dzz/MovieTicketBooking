using System;

namespace moviebooking.Application;

public interface IMinioService
{
    Task<string> UploadFileAsync(Stream filestream, string filename, string contentType);
}
