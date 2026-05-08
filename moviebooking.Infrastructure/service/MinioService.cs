using Microsoft.Extensions.Configuration;
using Minio;
using Minio.DataModel.Args;
using moviebooking.Application;

namespace moviebooking.Infrastructure.service;

public class Minioservice : IMinioService
{
      private readonly IMinioService _minioClient;
      private readonly string _bucketname;

      public Minioservice(IConfiguration configuration)
    {
        var endpoint = configuration["minio:Endpoint"]?? "localhost:9000";
        
    }
}