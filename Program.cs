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

            //��ȡtoken https://oapi.dingtalk.com/gettoken?appkey=&appsecret=
            _TokenResponseModel = JsonConvert.DeserializeObject<TokenResponseModel>(await HttpHepler.GetDataGetUrlYB("https://oapi.dingtalk.com/gettoken?appkey=" + _AppKey + "&appsecret=" + _AppSecret));

            // test
            var client = new DefaultDingTalkClient("https://oapi.dingtalk.com/user/get");
            var req = new OapiUserGetRequest();
            req.Userid = "manager8674";
            req.SetHttpMethod("GET");
            var rsp = client.Execute(req, _TokenResponseModel.Access_Token);

            //��ȡ���� https://oapi.dingtalk.com/department/list?access_token=
            var departments = JsonConvert.DeserializeObject<DepartmentReponseModel>(await HttpHepler.GetDataGetUrlYB("https://oapi.dingtalk.com/department/list?access_token=" + _TokenResponseModel.Access_Token));

            //ͨ�����Ż�ȡuser https://oapi.dingtalk.com/user/simplelist?access_token=&department_id=
            var users = JsonConvert.DeserializeObject<SimpleUserEResponseModel>(await HttpHepler.GetDataGetUrlYB("https://oapi.dingtalk.com/user/simplelist?access_token=" + _TokenResponseModel.Access_Token + "&department_id=1"));

            //ͨ�����Ż�ȡuserID https://oapi.dingtalk.com/user/getDeptMember?access_token=&deptId=
            var userIDs = JsonConvert.DeserializeObject<UserIDListResponseModel>(await HttpHepler.GetDataGetUrlYB("https://oapi.dingtalk.com/user/getDeptMember?access_token=" + _TokenResponseModel.Access_Token + "&deptId=1"));

            //���� https://oapi.dingtalk.com/attendance/listRecord?access_token=
            var records = JsonConvert.DeserializeObject<RecordResponseModel>(await HttpHepler.GetDataPostJsonUrlYB("https://oapi.dingtalk.com/attendance/listRecord?access_token=" + _TokenResponseModel.Access_Token, JsonConvert.SerializeObject(new RecordRequestModel()
            {
                userIds = userIDs.UserIds,
                checkDateFrom = "2020-10-19 00:00:00",
                checkDateTo = "2020-10-19 23:59:59",
                isI18n = false
            })));


            // ͨ���ֻ��Ż�ȡ userId https://oapi.dingtalk.com/user/get_by_mobile?access_token=&mobile=
            var userID = JsonConvert.DeserializeObject<UserIDResponseModel>(await HttpHepler.GetDataGetUrlYB("https://oapi.dingtalk.com/user/get_by_mobile?access_token=" + _TokenResponseModel.Access_Token + "&mobile=16657119235"));


            // ͨ��userID ��ȡ�û����� https://oapi.dingtalk.com/user/get?access_token=&userid=
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

            //��ȡ��AccessToken��ȡAccessToken��ҪAppkey��Appsecret,������GTE
            DefaultDingTalkClient client = new DefaultDingTalkClient("https://oapi.dingtalk.com/gettoken");
            OapiGettokenRequest request = new OapiGettokenRequest();
            request.Appkey = "ding7nfi3xjh1zyi9mzy";//Appkey
            request.Appsecret = "NPw2kd_61hl4dmV3iy1rUc5hY6TvC-1KnT-6febDEZ_aZgDr-Kpd8jYbsvJYJo3q";//Appsecret
            request.SetHttpMethod("GET");
            OapiGettokenResponse response = client.Execute(request);
            //��ȡ��AccessToken
            string AccessToken = response.AccessToken;
            //���ݲ��Ż�ȡ��Urid
            DefaultDingTalkClient clie = new DefaultDingTalkClient("https://oapi.dingtalk.com/user/getDeptMember");
            OapiUserGetDeptMemberRequest req = new OapiUserGetDeptMemberRequest();
            req.DeptId = "1";
            req.SetHttpMethod("GET");
            OapiUserGetDeptMemberResponse rsp = clie.Execute(req, AccessToken);
            List<string> userid = rsp.UserIds;
            //��ȡ��Urid�����ڹ�˾��Ҫ���͵��Ǹ��˵�id
            string Urid = userid[0];
            //������Ϣ
            IDingTalkClient cl = new DefaultDingTalkClient("https://eco.taobao.com/router/rest");
            CorpMessageCorpconversationAsyncsendRequest req1 = new CorpMessageCorpconversationAsyncsendRequest();
            req1.Msgtype = "oa";//������Ϣ����oa����ʽ���͵�,�����Ļ���text,image����ʽ
            req1.AgentId = 917416506;//΢Ӧ��ID
            req1.UseridList = Urid;//����Ϣ��userId,�����by��˾�����֣��ڸù�˾������һ��Ψһ��ʶ��
            req1.ToAllUser = false;//�Ƿ񷢸�������
                                   //��Ϣ�ı�
            req1.Msgcontent = "{\"message_url\": \"http://dingtalk.com\",\"head\": {\"bgcolor\": \"FFBBBBBB\",\"text\": \"ͷ������\"},\"body\": {\"title\": \"���ı���\",\"form\": [{\"key\": \"����:\", \"value\": \"����\" },{\"key\": \"����:\", \"value\": \"20\" },{\"key\": \"���:\", \"value\": \"1.8��\"},{\"key\": \"����:\",\"value\": \"130��\"},{\"key\": \"ѧ��:\",\"value\": \"����\"},{\"key\": \"����:\",\"value\": \"����������\"}],\"rich\": {\"num\": \"15.6\",\"unit\": \"Ԫ\"},\"content\": \"����ı�����ı�����ı�����ı�����ı�����ı�����ı�����ı�����ı�����ı�����ı�����ı�\",\"image\": \"@lADOADmaWMzazQKA\",\"file_count\": \"3\",\"author\": \"���� \"}}";
            CorpMessageCorpconversationAsyncsendResponse rsp1 = cl.Execute(req1, AccessToken);//������Ϣ

        }
    }
}