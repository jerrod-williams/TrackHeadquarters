using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TrackHeadquarters.Data;
using Volo.Abp.DependencyInjection;

namespace TrackHeadquarters.EntityFrameworkCore;

public class EntityFrameworkCoreTrackHeadquartersDbSchemaMigrator
    : ITrackHeadquartersDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreTrackHeadquartersDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the TrackHeadquartersDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TrackHeadquartersDbContext>()
            .Database
            .MigrateAsync();
    }
}
