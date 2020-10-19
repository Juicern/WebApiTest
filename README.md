# WebApiTest
调用钉钉API的.NET测试

## 注意事项

1. vs必须为2019版本，2017及以前无法使用.NET core 3.1

2. 在钉钉SDK处需下载.NET core版本的SDK

3. .NET core 3.1 使用微软自己的JSON库，因为bug太多，建议使用原来的[Newtonsoft](https://www.nuget.org/packages/Microsoft.AspNetCore.Mvc.NewtonsoftJson/)

4. dingtalk-sdk-netcore需放在文件外，否则会报错(引用了.net framework的东西)

5. 需要在钉钉的开放平台修改权限，否则获取时会显示：没有权限，而获取不到信息

6. 需要把当前IP加入白名单中，否则会报“访问IP不在白名单之中”

7. 需要在开放平台把权限范围改为“全部员工”，否则获取部门ID时会报错“请求的部门ID不在授权范围内”

8. 

   

   