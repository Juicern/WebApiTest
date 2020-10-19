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
                checkDateFrom = "2020-10-19 00:00:00",
                checkDateTo = "2020-10-19 23:59:59",
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

            //获取到AccessToken获取AccessToken需要Appkey和Appsecret,请求是GTE
            DefaultDingTalkClient client = new DefaultDingTalkClient("https://oapi.dingtalk.com/gettoken");
            OapiGettokenRequest request = new OapiGettokenRequest();
            request.Appkey = "ding7nfi3xjh1zyi9mzy";//Appkey
            request.Appsecret = "NPw2kd_61hl4dmV3iy1rUc5hY6TvC-1KnT-6febDEZ_aZgDr-Kpd8jYbsvJYJo3q";//Appsecret
            request.SetHttpMethod("GET");
            OapiGettokenResponse response = client.Execute(request);
            //获取到AccessToken
            string AccessToken = response.AccessToken;
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
            req1.Msgcontent = "{\"message_url\": \"http://dingtalk.com\",\"head\": {\"bgcolor\": \"FFBBBBBB\",\"text\": \"头部标题\"},\"body\": {\"title\": \"正文标题\",\"form\": [{\"key\": \"姓名:\", \"value\": \"张三\" },{\"key\": \"年龄:\", \"value\": \"20\" },{\"key\": \"身高:\", \"value\": \"1.8米\"},{\"key\": \"体重:\",\"value\": \"130斤\"},{\"key\": \"学历:\",\"value\": \"本科\"},{\"key\": \"爱好:\",\"value\": \"打球、听音乐\"}],\"rich\": {\"num\": \"15.6\",\"unit\": \"元\"},\"content\": \"大段文本大段文本大段文本大段文本大段文本大段文本大段文本大段文本大段文本大段文本大段文本大段文本\",\"image\": \"@lADOADmaWMzazQKA\",\"file_count\": \"3\",\"author\": \"李四 \"}}";
            CorpMessageCorpconversationAsyncsendResponse rsp1 = cl.Execute(req1, AccessToken);//发送消息

        }
    }
}