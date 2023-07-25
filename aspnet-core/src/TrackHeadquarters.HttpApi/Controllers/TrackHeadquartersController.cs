using TrackHeadquarters.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TrackHeadquarters.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TrackHeadquartersController : AbpControllerBase
{
    protected TrackHeadquartersController()
    {
        LocalizationResource = typeof(TrackHeadquartersResource);
    }
}
