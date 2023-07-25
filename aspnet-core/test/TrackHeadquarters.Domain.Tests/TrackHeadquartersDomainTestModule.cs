using TrackHeadquarters.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TrackHeadquarters;

[DependsOn(
    typeof(TrackHeadquartersEntityFrameworkCoreTestModule)
    )]
public class TrackHeadquartersDomainTestModule : AbpModule
{

}
