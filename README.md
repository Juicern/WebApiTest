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

8. 连续发送相同消息时，无法接收，To_all_user设置为true时，一天最多发送三次，这些都不会有错误提示。

9. 更新角色，有bug，提示需要修改为GET，修改后依然报错称缺少CorId和APPkey，但是新版本小程序已经没有CorId了。

10. 添加外部联系人 官方代码有问题(已解决，需要在OpenExtContactDomain前加上request名
    ，然而又有新问题：还是和上面“更新角色”的报错一样，提示：缺少参数 corpid or appkey

    

    

    