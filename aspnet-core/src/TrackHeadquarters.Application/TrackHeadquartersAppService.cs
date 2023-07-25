using System;
using System.Collections.Generic;
using System.Text;
using TrackHeadquarters.Localization;
using Volo.Abp.Application.Services;

namespace TrackHeadquarters;

/* Inherit your application services from this class.
 */
public abstract class TrackHeadquartersAppService : ApplicationService
{
    protected TrackHeadquartersAppService()
    {
        LocalizationResource = typeof(TrackHeadquartersResource);
    }
}
