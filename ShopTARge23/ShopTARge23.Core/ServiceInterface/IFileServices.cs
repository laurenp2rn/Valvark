﻿using ShopTARge23.Core.Domain;
using ShopTARge23.Core.Dto;

namespace ShopTARge23.Core.ServiceInterface
{
    public interface IFileServices
    {
        void FilesToApi(SpaceshipDto dto, Spaceship spaceship);
        Task<List<FileToApi>> RemoveImagesFromApi(FileToApiDto[] dtos);
        Task<FileToApi> RemoveImageFromApi(FileToApiDto dto);
        void UploadFilesToDatabase(RealEstateDto dto, RealEstate domain);
        void UploadFilesToDatabase(KindergartenDto dto, Kindergarten domain);
        Task<FileToDatabase> RemoveFileFromDatabase(FileToDatabaseDto dto);
        Task<FileToDatabase> RemoveFilesFromDatabase(FileToDatabaseDto[] dtos);
    }
}