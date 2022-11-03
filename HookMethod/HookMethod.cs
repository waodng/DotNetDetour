
using DotNetDetour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*-------------------------------------------------------------------------
* 版权所有：WQKJ
* 作者：WQKJ
* 联系方式：
* 创建时间： 2022-11-03 09:22:42
* 版本号：v1.0
* 本类主要用途描述：
*  -------------------------------------------------------------------------*/
namespace HookNetMethod
{
    /// <summary>
    /// 我们自行实现一个类来修改Run方法的行为，此类用IMethodHook接口修饰
    /// </summary>
    public class HookMethod : IMethodHook
    {
        //我们实现一个新Run方法，并标记为HookMethod，覆盖SolidClass中的Run方法
        [HookMethod("HookNetMethod.TestMethod")]
        public string RunA(string msg)
        {
            string s = Run_Original(msg);
            return "Hook " + s;
        }

        //实现一个占位方法，此方法代表被Hook覆盖的原始方法
        [OriginalMethod]
        public string Run_Original(string msg)
        {
            return null; //这里写什么无所谓，能编译过即可
        }

    }
}
