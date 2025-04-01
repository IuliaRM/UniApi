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
    public class SesiuneExameneInfo
    {

        ///<summary>
        /// Property for ID_SesiuneExamene ()
        ///</summary>
        public long ID_SesiuneExamene { get; set; }

        ///<summary>
        /// Property for DenumireSesiuneExamene ()
        ///</summary>
        public string DenumireSesiuneExamene { get; set; }

 
        ///<summary>
        /// Property for DataInceput ()
        ///</summary>
        public DateTime DataInceput { get; set; }

        ///<summary>
        /// Property for DataSfarsit ()
        ///</summary>
        public DateTime DataSfarsit { get; set; }

        ///<summary>
        /// Property for DataLimitaNote ()
        ///</summary>
        public DateTime DataLimitaNote { get; set; }

        ///<summary>
        /// Property for Activa ()
        ///</summary>
        public bool Activa { get; set; }

        ///<summary>
        /// Property for ID_TipSesiuneExamene ()
        ///</summary>
        public int ID_TipSesiuneExamene { get; set; }

        public bool ExistaDate { get; set; }

        public bool ProfesoriiPotProgramaExamene { get; set; }
    }
}
