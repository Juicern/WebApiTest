using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiCateringCooplistGetBetaResponse.
    /// </summary>
    public class OapiCateringCooplistGetBetaResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public ResultDomain Result { get; set; }

        /// <summary>
        /// success or not
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// MealitemlistDomain Data Structure.
/// </summary>
[Serializable]

public class MealitemlistDomain : TopObject
{
	        /// <summary>
	        /// 送达时间 HH:mm
	        /// </summary>
	        [XmlElement("delivery_time")]
	        public string DeliveryTime { get; set; }
	
	        /// <summary>
	        /// id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 点餐项名称
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// MealSettingListDomain Data Structure.
/// </summary>
[Serializable]

public class MealSettingListDomain : TopObject
{
	        /// <summary>
	        /// 缩略地址，可为空
	        /// </summary>
	        [XmlElement("address")]
	        public string Address { get; set; }
	
	        /// <summary>
	        /// 送餐详细地址
	        /// </summary>
	        [XmlElement("address_detail")]
	        public string AddressDetail { get; set; }
	
	        /// <summary>
	        /// 企业corpId
	        /// </summary>
	        [XmlElement("corp_id")]
	        public string CorpId { get; set; }
	
	        /// <summary>
	        /// 企业名称
	        /// </summary>
	        [XmlElement("corp_name")]
	        public string CorpName { get; set; }
	
	        /// <summary>
	        /// 企业logo的url
	        /// </summary>
	        [XmlElement("logo")]
	        public string Logo { get; set; }
	
	        /// <summary>
	        /// mealItemList
	        /// </summary>
	        [XmlArray("meal_item_list")]
	        [XmlArrayItem("mealitemlist")]
	        public List<MealitemlistDomain> MealItemList { get; set; }
	
	        /// <summary>
	        /// 点餐时间枚举值：2-法定工作日3-双休及节假日
	        /// </summary>
	        [XmlElement("meal_time")]
	        public long MealTime { get; set; }
}

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 是否有下一项数据
	        /// </summary>
	        [XmlElement("has_next")]
	        public bool HasNext { get; set; }
	
	        /// <summary>
	        /// list
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("meal_setting_list")]
	        public List<MealSettingListDomain> List { get; set; }
}

    }
}
