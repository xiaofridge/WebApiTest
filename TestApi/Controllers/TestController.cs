using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApi.Models;

namespace TestApi.Controllers
{
        public class TestController : ApiController
        {
            public static List<TestUseMode> allModeList = new List<TestUseMode>();

            [HttpGet]
            public IEnumerable<TestUseMode> GetAll()
            {
                return allModeList;
            }
            [HttpGet]
            public IEnumerable<TestUseMode> GetOne(string key)
            {
                return allModeList.FindAll((mode) => { if (mode.ModeKey.Equals(key)) return true; return false; });
            }
            [HttpPost]
            public bool PostNew(TestUseMode mode)
            {
                allModeList.Add(mode);
                return true;
            }

            [HttpDelete]
            public int Delete(string key)
            {
                return allModeList.RemoveAll((mode) => { if (mode.ModeKey == key) return true; return false; });
            }
            [HttpDelete]
            public int DeleteAll()
            {
                return allModeList.RemoveAll((mode) => { return true; });
            }
            [HttpPut]
            public int PutOne(string key, string value)
            {
                List<TestUseMode> upDataList = allModeList.FindAll((mode) => { if (mode.ModeKey == key) return true; return false; });
                foreach (var mode in upDataList)
                {
                    mode.ModeValue = value;
                }
                return upDataList.Count;
            }
        }
    }
