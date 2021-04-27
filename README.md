# WebApiTest

呼叫釘釘API的.NET測試

## 注意事項

1. vs必須為2019版本，2017及以前無法使用.NET core 3.1

2. 在釘釘SDK處需下載.NET core版本的SDK

3. .NET core 3.1 使用微軟自己的JSON庫，因為bug太多，建議使用原來的[Newtonsoft](https://www.nuget.org/packages/Microsoft.AspNetCore.Mvc.NewtonsoftJson/)

4. dingtalk-sdk-netcore需放在檔案外，否則會報錯(引用了.net framework的東西)

5. 需要在釘釘的開放平臺修改許可權，否則獲取時會顯示：沒有許可權，而獲取不到資訊

6. 需要把當前IP加入白名單中，否則會報“訪問IP不在白名單之中”

7. 需要在開放平臺把許可權範圍改為“全部員工”，否則獲取部門ID時會報錯“請求的部門ID不在授權範圍內”

8. 連續傳送相同訊息時，無法接收，To_all_user設定為true時，一天最多傳送三次，這些都不會有錯誤提示。

9. 更新角色，有bug，提示需要修改為GET，修改後依然報錯稱缺少CorId和APPkey，但是新版本小程式已經沒有CorId了。

10. 新增外部聯絡人 官方程式碼有問題(已解決，需要在OpenExtContactDomain前加上request名
    ，然而又有新問題：還是和上面“更新角色”的報錯一樣，提示：缺少引數 corpid or appkey

11. 更新代辦也有問題

12. 在傳送訊息和發起代辦中，可使用官方提供的類來賦值。

    

    

    
