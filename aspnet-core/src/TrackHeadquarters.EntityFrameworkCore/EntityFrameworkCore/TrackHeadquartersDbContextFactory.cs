using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TrackHeadquarters.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class TrackHeadquartersDbContextFactory : IDesignTimeDbContextFactory<TrackHeadquartersDbContext>
{
    public TrackHeadquartersDbContext CreateDbContext(string[] args)
    {
        TrackHeadquartersEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<TrackHeadquartersDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new TrackHeadquartersDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../TrackHeadquarters.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
