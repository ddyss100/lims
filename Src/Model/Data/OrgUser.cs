﻿/******************************************************************
 *
 * 所在模块：Model(数据实体)
 * 类 名 称：OrgUser(OrgUser)
 * 功能描述：
 * 
 * ------------创建信息------------------
 * 作    者：jjf001
 * 日    期：2013-11-05
 * xingzhewujiang1999@gmail.com
 * QQ:970355214
 * ------------编辑修改信息--------------
 * 作    者：
 * 日    期：
 * 内    容：
******************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Xml;

using Hope.Util;
using Hope.ITMS.Enums;

namespace Hope.ITMS.Model
{
    /// <summary>
    /// DataEntity OrgUser
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    [Serializable]
    public class OrgUser : BaseData
    {
        /// <summary>
        /// OrgUser
        /// </summary>
        public OrgUser()
        {
            Initialize();
        }
        
        #region Base Members ...

        /// <summary>
        /// ID、主键
        /// </summary>
        public virtual int ID
        {
            set;
            get;
        }

        /// <summary>
        /// 用户组ID，为0则不属于任何组
        /// </summary>
        public virtual int GroupID
        {
            set;
            get;
        }

        /// <summary>
        /// 姓名
        /// </summary>
        public virtual string Name
        {
            set;
            get;
        }

        /// <summary>
        /// 姓氏
        /// </summary>
        public virtual string FirstName
        {
            set;
            get;
        }

        /// <summary>
        /// 名字
        /// </summary>
        public virtual string LastName
        {
            set;
            get;
        }

        /// <summary>
        ///  性别，1：男；0：女
        /// </summary>
        public virtual int Gender
        {
            set;
            get;
        }

        /// <summary>
        /// 电子邮件地址
        /// </summary>
        public virtual string Email
        {
            set;
            get;
        }

        /// <summary>
        /// 密码
        /// </summary>
        public virtual string Password
        {
            set;
            get;
        }

        /// <summary>
        /// 注册时间
        /// </summary>
        public virtual DateTime RegTime
        {
            set;
            get;
        }

        /// <summary>
        /// 登录次数
        /// </summary>
        public virtual int LoginTimes
        {
            set;
            get;
        }

        /// <summary>
        /// 上次登录时间
        /// </summary>
        public virtual DateTime LastLoginTime
        {
            set;
            get;
        }

        /// <summary>
        /// 登录失败次数
        /// </summary>
        public virtual int ErrorTimes
        {
            set;
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime LastErrorTime
        {
            set;
            get;
        }

        /// <summary>
        /// 状态
        /// </summary>
        public virtual int Status
        {
            set;
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual Dictionary<string, string> Extend
        {
            set;
            get;
        }

        /// <summary>
        /// 备注说明
        /// </summary>
        public virtual string Remark
        {
            set;
            get;
        }

        #endregion
        
        #region Base Methods ...
        
        /// <summary>
        /// 转换为XML节点
        /// </summary>
        /// <param name="parentDoc">父XML文档</param>
        /// <returns>返回XML文档节点</returns>
        public virtual XmlNode ToXmlNode(XmlDocument parentDoc)
        {
            return ToXmlNode(parentDoc, "item");
        }
        
        /// <summary>
        /// 转换为XML节点
        /// </summary>
        /// <param name="parentDoc">父XML文档</param>
        /// <param name="nodeName">节点名</param>
        /// <returns>返回XML文档节点</returns>
        public virtual XmlNode ToXmlNode(XmlDocument parentDoc, string nodeName)
        {
            XmlDocument xml = parentDoc;
            if (xml == null)
            {
                xml = XMLHelper.CreateXmlDoc();
            }
            XmlNode xn = parentDoc.CreateNode("element", nodeName, "");
            
            XmlElement xe;
            xe = CreateElement(xml, Columns.ID.ToString(),ID.ToString());
            xn.AppendChild(xe);
            xe = CreateElement(xml, Columns.GroupID.ToString(),GroupID.ToString());
            xn.AppendChild(xe);
            xe = CreateElement(xml, Columns.Name.ToString(),Name.ToString());
            xn.AppendChild(xe);
            xe = CreateElement(xml, Columns.FirstName.ToString(),FirstName.ToString());
            xn.AppendChild(xe);
            xe = CreateElement(xml, Columns.LastName.ToString(),LastName.ToString());
            xn.AppendChild(xe);
            xe = CreateElement(xml, Columns.Gender.ToString(),Gender.ToString());
            xn.AppendChild(xe);
            xe = CreateElement(xml, Columns.Email.ToString(),Email.ToString());
            xn.AppendChild(xe);
            xe = CreateElement(xml, Columns.Password.ToString(),Password.ToString());
            xn.AppendChild(xe);
            xe = CreateElement(xml, Columns.RegTime.ToString(),RegTime.ToString("yyyy-MM-dd HH:mm:ss"));
            xn.AppendChild(xe);
            xe = CreateElement(xml, Columns.LoginTimes.ToString(),LoginTimes.ToString());
            xn.AppendChild(xe);
            xe = CreateElement(xml, Columns.LastLoginTime.ToString(),LastLoginTime.ToString("yyyy-MM-dd HH:mm:ss"));
            xn.AppendChild(xe);
            xe = CreateElement(xml, Columns.ErrorTimes.ToString(),ErrorTimes.ToString());
            xn.AppendChild(xe);
            xe = CreateElement(xml, Columns.LastErrorTime.ToString(),LastErrorTime.ToString("yyyy-MM-dd HH:mm:ss"));
            xn.AppendChild(xe);
            xe = CreateElement(xml, Columns.Status.ToString(),Status.ToString());
            xn.AppendChild(xe);
            xe = CreateElement(xml, Columns.Extend.ToString(),Extend.ToString());
            xn.AppendChild(xe);
            xe = CreateElement(xml, Columns.Remark.ToString(),Remark.ToString());
            xn.AppendChild(xe);
            
            return xn;
        }
        
        /// <summary>
        /// 设置初始化默认值
        /// </summary>
        private void Initialize()
        {
            ID = 0;
            GroupID = 0;
            Name = string.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            Gender = 0;
            Email = string.Empty;
            Password = string.Empty;
            RegTime = DateTime.Now;
            LoginTimes = 0;
            LastLoginTime = DateTime.Now;
            ErrorTimes = 0;
            LastErrorTime = DateTime.Now;
            Status = 0;
            Extend = new Dictionary<string, string>();
            Remark = string.Empty;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "OrgUser";
        }
        #endregion
        
        #region Order Columns ...

        /// <summary>
        /// 
        /// </summary>
        public enum Columns
        {
            ID,
            GroupID,
            Name,
            FirstName,
            LastName,
            Gender,
            Email,
            Password,
            RegTime,
            LoginTimes,
            LastLoginTime,
            ErrorTimes,
            LastErrorTime,
            Status,
            Extend,
            Remark,
        }

        #endregion
        
    }
}


