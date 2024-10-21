﻿public class FileToDatabase
{
    public Guid Id { get; set; }
    public string ImageTitle { get; set; }
    public byte[] ImageData { get; set; }
    public Guid? RealEstateId { get; set; }
    public Guid? KindergartenId { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}