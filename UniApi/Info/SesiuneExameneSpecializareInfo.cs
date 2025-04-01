/*
' Module: Your Module
' Copyright (c) 2019 YourCompany
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/
using System;
using System.Web.Caching;
using System.Xml.Serialization;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Content;

namespace UniApi.Info
{
    public class SesiuneExameneSpecializareInfo: SesiuneExameneInfo
    {

        ///<summary>
        /// Property for ID_SesiuneExamene ()
        ///</summary>
        public long ID_SesiuneExameneSpecializare { get; set; }

        ///<summary>
        /// Property for ID_Specializare ()
        ///</summary>
        public long ID_Specializare { get; set; }

        public string DenumireCFSA { get; set; }

        ///<summary>
        /// Property for ID_AnStudiu ()
        ///</summary>
        public long ID_AnStudiu { get; set; }

        ///<summary>
        /// Property for DataInceput ()
        ///</summary>
        public DateTime DataInceputPeSpec { get; set; }

        ///<summary>
        /// Property for DataSfarsit ()
        ///</summary>
        public DateTime DataSfarsitPeSpec { get; set; }

        ///<summary>
        /// Property for DataLimitaNote ()
        ///</summary>
        public DateTime DataLimitaNotePeSpec { get; set; }

        public string DenumireSesiuneExameneSpecializare { get; set; }

        public string DenumireTipSesiuneExamene { get; set; }

        public int ID_TipSesiuneExamene { get; set; }

        public bool NumaiStudentiiDinMetaCurenta { get; set; }

        public string DenumireMetaSpecializare { get; set; }

    }
}
