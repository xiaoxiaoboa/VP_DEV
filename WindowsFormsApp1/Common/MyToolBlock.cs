using System;
using System.Collections.Generic;
using System.Linq;
using Cognex.VisionPro;
using Cognex.VisionPro.PMAlign;
using Cognex.VisionPro.ToolBlock;

namespace WindowsFormsApp1.Common {
    public class MyToolBlock {
        private static readonly MyToolBlock _instance = new MyToolBlock();
        private readonly object _lock = new object();
        private CogToolBlock _cogToolBlock;


        private MyToolBlock() { }

        public static MyToolBlock Instance => _instance;

        public int RunCount{ get; set; }

        public int PassCount{ get; set; }

        public CogToolBlock ToolBlock{
            get {
                lock (_lock) {
                    return _cogToolBlock;
                }
            }
        }

        // 设置ToolBlock
        public void SetToolBlock(CogToolBlock cogToolBlock) {
            lock (_lock) {
                if (_cogToolBlock == null) {
                    _cogToolBlock = cogToolBlock;
                }
            }
        }


        // 获取PMA结果
        public List<MyPmaResult> GetPmaResult() {
            var myPmaResults = new List<MyPmaResult>();
            if (_cogToolBlock.Tools["CogPMAlignTool1"] is CogPMAlignTool pma) {
                if (pma.RunStatus.Result == CogToolResultConstants.Accept && pma.Results != null) {
                    myPmaResults.AddRange(from CogPMAlignResult r in pma.Results
                        select new MyPmaResult(r.Score, r.GetPose().RotationX, r.GetPose().TranslationY));
                }
            }


            return myPmaResults;
        }
    }
}