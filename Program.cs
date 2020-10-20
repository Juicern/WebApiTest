/*
using WebApiTest.Common;
using WebApiTest.Models.RequestModel;
using WebApiTest.Models.ResponseModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DingTalk.Api;
using DingTalk.Api.Request;
using DingTalk.Api.Response;

namespace WebApiTest
{
    class Program
    {
        private const string _AppKey = "ding7nfi3xjh1zyi9mzy";
        private const string _AppSecret = "NPw2kd_61hl4dmV3iy1rUc5hY6TvC-1KnT-6febDEZ_aZgDr-Kpd8jYbsvJYJo3q";
        private static TokenResponseModel _TokenResponseModel = null;
        static async Task Main(string[] args)
        {

            //获取token https://oapi.dingtalk.com/gettoken?appkey=&appsecret=
            _TokenResponseModel = JsonConvert.DeserializeObject<TokenResponseModel>(await HttpHepler.GetDataGetUrlYB("https://oapi.dingtalk.com/gettoken?appkey=" + _AppKey + "&appsecret=" + _AppSecret));

            // test
            var client = new DefaultDingTalkClient("https://oapi.dingtalk.com/user/get");
            var req = new OapiUserGetRequest();
            req.Userid = "manager8674";
            req.SetHttpMethod("GET");
            var rsp = client.Execute(req, _TokenResponseModel.Access_Token);

            //获取部门 https://oapi.dingtalk.com/department/list?access_token=
            var departments = JsonConvert.DeserializeObject<DepartmentReponseModel>(await HttpHepler.GetDataGetUrlYB("https://oapi.dingtalk.com/department/list?access_token=" + _TokenResponseModel.Access_Token));

            //通过部门获取user https://oapi.dingtalk.com/user/simplelist?access_token=&department_id=
            var users = JsonConvert.DeserializeObject<SimpleUserEResponseModel>(await HttpHepler.GetDataGetUrlYB("https://oapi.dingtalk.com/user/simplelist?access_token=" + _TokenResponseModel.Access_Token + "&department_id=1"));

            //通过部门获取userID https://oapi.dingtalk.com/user/getDeptMember?access_token=&deptId=
            var userIDs = JsonConvert.DeserializeObject<UserIDListResponseModel>(await HttpHepler.GetDataGetUrlYB("https://oapi.dingtalk.com/user/getDeptMember?access_token=" + _TokenResponseModel.Access_Token + "&deptId=1"));

            //考勤 https://oapi.dingtalk.com/attendance/listRecord?access_token=
            var records = JsonConvert.DeserializeObject<RecordResponseModel>(await HttpHepler.GetDataPostJsonUrlYB("https://oapi.dingtalk.com/attendance/listRecord?access_token=" + _TokenResponseModel.Access_Token, JsonConvert.SerializeObject(new RecordRequestModel()
            {
                userIds = userIDs.UserIds,
                checkDateFrom = "2020-10-20 00:00:00",
                checkDateTo = "2020-10-20 23:59:59",
                isI18n = false
            })));


            // 通过手机号获取 userId https://oapi.dingtalk.com/user/get_by_mobile?access_token=&mobile=
            var userID = JsonConvert.DeserializeObject<UserIDResponseModel>(await HttpHepler.GetDataGetUrlYB("https://oapi.dingtalk.com/user/get_by_mobile?access_token=" + _TokenResponseModel.Access_Token + "&mobile=16657119235"));


            // 通过userID 获取用户详情 https://oapi.dingtalk.com/user/get?access_token=&userid=
            var user = JsonConvert.DeserializeObject<UserResponseModel>(await HttpHepler.GetDataGetUrlYB("https://oapi.dingtalk.com/user/get?access_token=" + _TokenResponseModel.Access_Token + "&userid=" + userID.UserID));

            Console.ReadLine();
        }
    }
}
*/
using DingTalk.Api;
using DingTalk.Api.Request;
using DingTalk.Api.Response;
using FastJSON;
using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            


            //获取到AccessToken获取AccessToken需要Appkey和Appsecret,请求是GET
            DefaultDingTalkClient client = new DefaultDingTalkClient("https://oapi.dingtalk.com/gettoken");
            OapiGettokenRequest request = new OapiGettokenRequest();
            request.Appkey = "ding7nfi3xjh1zyi9mzy";//Appkey
            request.Appsecret = "NPw2kd_61hl4dmV3iy1rUc5hY6TvC-1KnT-6febDEZ_aZgDr-Kpd8jYbsvJYJo3q";//Appsecret
            request.SetHttpMethod("GET");
            OapiGettokenResponse response = client.Execute(request);
            //获取到AccessToken
            string AccessToken = response.AccessToken;


            // 创建员工
            DefaultDingTalkClient client1 = new DefaultDingTalkClient("https://oapi.dingtalk.com/user/create");
            OapiUserCreateRequest request1 = new OapiUserCreateRequest();
            request1.Userid = "zhangsan";
            request1.Mobile = "16657119236";
            request1.Email = "535497379@qq.com";
            request1.Name = "张三";
            List<long> departments1 = new List<long>();
            departments1.Add(1L);
            request1.Department = JSON.ToJSON(departments1);
            OapiUserCreateResponse response1 = client1.Execute(request1, AccessToken);
            Console.WriteLine("创建员工：");
            Console.WriteLine(response1.Body);
            Console.WriteLine();

            // 删除员工
            DefaultDingTalkClient client2 = new DefaultDingTalkClient("https://oapi.dingtalk.com/user/delete");
            OapiUserDeleteRequest request2 = new OapiUserDeleteRequest();
            request2.Userid = "zhangsan";
            request2.SetHttpMethod("GET");
            OapiUserDeleteResponse response2 = client2.Execute(request2, AccessToken);
            Console.WriteLine("删除员工：");
            Console.WriteLine(response2.Body);
            Console.WriteLine();

            // 获取用户信息
            DefaultDingTalkClient client3 = new DefaultDingTalkClient("https://oapi.dingtalk.com/user/get");
            OapiUserGetRequest request3 = new OapiUserGetRequest();
            request3.Userid = "manager8674";
            request3.SetHttpMethod("GET");
            OapiUserGetResponse response3 = client3.Execute(request3, AccessToken);
            Console.WriteLine("获取用户信息：");
            Console.WriteLine(response3.Body);
            Console.WriteLine();

            // 获取管理员信息
            DefaultDingTalkClient client4 = new DefaultDingTalkClient("https://oapi.dingtalk.com/user/get_admin");
            OapiUserGetAdminRequest request4 = new OapiUserGetAdminRequest();
            request4.SetHttpMethod("GET");
            OapiUserGetAdminResponse response4 = client4.Execute(request4, AccessToken);
            Console.WriteLine("获取管理员信息：");
            Console.WriteLine(response4.Body);
            Console.WriteLine();

            // 创建角色
            DefaultDingTalkClient client5 = new DefaultDingTalkClient("https://oapi.dingtalk.com/role/add_role");
            OapiRoleAddRoleRequest request5 = new OapiRoleAddRoleRequest();
            request5.RoleName = "Test";
            request5.GroupId = 1631985729L;
            OapiRoleAddRoleResponse response5 = client5.Execute(request5, AccessToken);
            Console.WriteLine("创建角色：");
            Console.WriteLine(response5.Body);
            Console.WriteLine();

            //更新角色，有bug，提示需要修改为GET，修改后依然报错称缺少CorId和APPkey，但是新版本小程序已经没有CorId了。
            DefaultDingTalkClient client6 = new DefaultDingTalkClient("https://oapi.dingtalk.com/role/update_role");
            OapiRoleUpdateRoleRequest request6 = new OapiRoleUpdateRoleRequest();
            request6.RoleName = "AnyThing";
            request6.RoleId = 1;
            request6.SetHttpMethod("GET");
            OapiRoleUpdateRoleResponse response6 = client.Execute(request6, AccessToken);
            Console.WriteLine("更新角色");
            Console.WriteLine(response6.Body);
            Console.WriteLine();

            // 删除角色
            DefaultDingTalkClient client7 = new DefaultDingTalkClient("https://oapi.dingtalk.com/topapi/role/deleterole");
            OapiRoleDeleteroleRequest request7 = new OapiRoleDeleteroleRequest();
            request7.RoleId = response5.RoleId;
            OapiRoleDeleteroleResponse response7 = client7.Execute(request7, AccessToken);
            Console.WriteLine("删除角色:");
            Console.WriteLine(response7.Body);
            Console.WriteLine();

            //// 添加外部联系人 官方代码有问题
            //DefaultDingTalkClient client8 = new DefaultDingTalkClient("https://oapi.dingtalk.com/topapi/extcontact/create");
            //OapiExtcontactCreateRequest request8 = new OapiExtcontactCreateRequest();
            //OpenExtContactDomain 

            // 获取外部联系人列表
            DefaultDingTalkClient client9 = new DefaultDingTalkClient("https://oapi.dingtalk.com/topapi/extcontact/list");
            OapiExtcontactListRequest request9 = new OapiExtcontactListRequest();
            request9.Size = 20L;
            request9.Offset = 0L;
            OapiExtcontactListResponse response9 = client9.Execute(request9, AccessToken);
            Console.WriteLine("获取外部联系人列表:");
            Console.WriteLine(response9.Body);
            Console.WriteLine();

            //// 创建群会话
            //DefaultDingTalkClient client10 = new DefaultDingTalkClient("https://oapi.dingtalk.com/chat/create");
            //OapiChatCreateRequest request10 = new OapiChatCreateRequest();
            //request10.Name = "TestCreate";
            //request10.Owner = "manager8674";
            //request10.Useridlist ??= new List<string>();
            //request10.Useridlist.Add("manager8674");
            //OapiChatCreateResponse response10 = client10.Execute(request10, AccessToken);
            //Console.WriteLine(response10.Body);
            //Console.WriteLine();

            //// 获取群会话
            //DefaultDingTalkClient client11 = new DefaultDingTalkClient("https://oapi.dingtalk.com/chat/get");
            //OapiChatGetRequest request11 = new OapiChatGetRequest();
            //request11.Chatid = response10.Chatid;
            //request11.SetHttpMethod("GET");
            //OapiChatGetResponse response11 = client11.Execute(request11, AccessToken);
            //Console.WriteLine(response11.Body);
            //Console.WriteLine();

            //// 更新群对话
            //DefaultDingTalkClient client12 = new DefaultDingTalkClient("https://oapi.dingtalk.com/chat/update");
            //OapiChatUpdateRequest request12 = new OapiChatUpdateRequest();
            //request12.Chatid = response10.Chatid;
            //request12.Name = "TestUpdate";
            //OapiChatUpdateResponse response12 = client12.Execute(request12, AccessToken);
            //Console.WriteLine(response12.Body);
            //Console.WriteLine();

            // 发送工作通知
            DefaultDingTalkClient client13 = new DefaultDingTalkClient("https://oapi.dingtalk.com/topapi/message/corpconversation/asyncsend_v2");
            OapiMessageCorpconversationAsyncsendV2Request request13 = new OapiMessageCorpconversationAsyncsendV2Request();
            request13.AgentId = 917416506L;
            request13.ToAllUser = true;
            request13.Msg = @"{
                ""msgtype"": ""oa"",
                ""oa"": {
                    ""message_url"": ""http://dingtalk.com"",
                    ""head"": {
                        ""bgcolor"": ""FFBBBBBB"",
                        ""text"": ""头部标题""
                    },
                    ""body"": {
                        ""title"": ""正文标题"",
                        ""form"": [
                            {""key"": ""姓名:"", ""value"": ""张三""},
                            {""key"": ""年龄:"", ""value"": ""20""},
                            {""key"": ""身高:"", ""value"": ""1.8米""},
                            {""key"": ""体重:"", ""value"": ""130斤""},
                            {""key"": ""学历:"", ""value"": ""本科""},
                            {""key"": ""爱好:"", ""value"": ""打球、听音乐""}
                        ],
                        ""rich"": {""num"": ""15.6"", ""unit"": ""元""},
                        ""content"": ""大段文本大段文本大段文本大段文本大段文本大段文本"",
                        ""image"": ""@lADOADmaWMzazQKA"",
                        ""file_count"": ""3"",
                        ""author"": ""李四""
                    }
                }
            }";
            OapiMessageCorpconversationAsyncsendV2Response response13 = client13.Execute(request13, AccessToken);
            Console.WriteLine("发送工作通知:");
            Console.WriteLine(response13.Body);
            Console.WriteLine();







            //根据部门获取到Urid
            DefaultDingTalkClient clie = new DefaultDingTalkClient("https://oapi.dingtalk.com/user/getDeptMember");
            OapiUserGetDeptMemberRequest req = new OapiUserGetDeptMemberRequest();
            req.DeptId = "1";
            req.SetHttpMethod("GET");
            OapiUserGetDeptMemberResponse rsp = clie.Execute(req, AccessToken);
            List<string> userid = rsp.UserIds;
            //获取到Urid就是在公司里要发送到那个人的id
            string Urid = userid[0];
            //发送消息
            IDingTalkClient cl = new DefaultDingTalkClient("https://eco.taobao.com/router/rest");
            CorpMessageCorpconversationAsyncsendRequest req1 = new CorpMessageCorpconversationAsyncsendRequest();
            req1.Msgtype = "oa";//发送消息是以oa的形式发送的,其他的还有text,image等形式
            req1.AgentId = 917416506;//微应用ID
            req1.UseridList = Urid;//收信息的userId,这个是by公司来区分，在该公司内这是一个唯一标识符
            req1.ToAllUser = false;//是否发给所有人
                                   //消息文本
            //req1.Msgcontent = "{\"message_url\": \"http://dingtalk.com\",\"head\": {\"bgcolor\": \"FFBBBBBB\",\"text\": \"头部标题\"},\"body\": {\"title\": \"拿钱学习\",\"form\": [{\"key\": \"姓名:\", \"value\": \"hong\" },{\"key\": \"年龄:\", \"value\": \"18\" },{\"key\": \"身高:\", \"value\": \"1.6米\"},{\"key\": \"体重:\",\"value\": \"90斤\"},{\"key\": \"学历:\",\"value\": \"硕士\"},{\"key\": \"爱好:\",\"value\": \"学习\"}],\"rich\": {\"num\": \"10000\",\"unit\": \"元\"},\"content\": \"快去学习！！！\",\"file_count\": \"1\",\"author\": \"小白\"}}";
            //CorpMessageCorpconversationAsyncsendResponse rsp1 = cl.Execute(req1, AccessToken);//发送消息

            req1.Msgcontent = @"{
                ""message_url"": ""http://dingtalk.com"",
                ""head"": {""bgcolor"": ""FFBBBBBB"",""text"": ""头部标题""},
                ""body"": {
                    ""title"": ""拿钱学习"",
                    ""form"": [
                        {""key"": ""姓名:"", ""value"": ""hong"" },
                        {""key"": ""年龄:"", ""value"": ""18"" },
                        {""key"": ""身高:"", ""value"": ""1.6米""},
                        {""key"": ""体重:"", ""value"": ""90斤""},
                        {""key"": ""学历:"", ""value"": ""硕士""},
                        {""key"": ""爱好:"", ""value"": ""学习""}],
                    ""rich"": {""num"": ""10000"",""unit"": ""元""},
                    ""content"": ""快去学习！！！"",
                    ""file_count"": ""1"",
                    ""author"": ""小白""
                }
            }";
            CorpMessageCorpconversationAsyncsendResponse rsp1 = cl.Execute(req1, AccessToken);//发送消息

            Console.WriteLine(rsp1.Body);
        }
    }
}