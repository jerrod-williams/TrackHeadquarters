import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'TrackHeadquarters',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44387/',
    redirectUri: baseUrl,
    clientId: 'TrackHeadquarters_App',
    responseType: 'code',
    scope: 'offline_access TrackHeadquarters',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44387',
      rootNamespace: 'TrackHeadquarters',
    },
  },
} as Environment;
