# WebApiTest
调用钉钉API的.NET测试

## 注意事项

1. vs必须为2019版本，2017及以前无法使用.NET core 3.1
2. 在钉钉SDK处需下载.NET core版本的SDK
3. .NET core 3.1 使用微软自己的JSON库，因为bug太多，建议使用原来的[Newtonsoft](https://www.nuget.org/packages/Microsoft.AspNetCore.Mvc.NewtonsoftJson/)
4. 