# TuyaDoorSensorWifi
Check your tuya compatible door sensor status via windows

## Linking a Tuya device with Smart Link
Check out the instructions at [codetheweb/tuyapi](https://github.com/codetheweb/tuyapi/blob/master/docs/SETUP.md)

## Install NuGet Package
```C#
Newtonsoft.Json
RestSharp
```
## Set Your Information Into DeviceInfoProp Class 
```C#
public const string device_id = "your device id";
public static string client_id = "your client id";
public static string secret = "your secret key";
```
