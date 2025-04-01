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

namespace UniApi.Info
{
    public class SesiuneExameneDeschidereSpecialaInfo
    {

        public long ID_SesiuneExameneDeschidereSpeciala { get; set; }


        public long ID_SesiuneExamene { get; set; }


        public long ID_Profesor { get; set; }


        public long ID_AnUniv { get; set; }


        public long ID_DetaliuPlanSemestru { get; set; }


        public DateTime DataDeschidere { get; set; }


        public int ID_UtilizatorDeschidere { get; set; }


        public string UsernameUtilizatorDeschidere { get; set; }


        public DateTime DataInchidere { get; set; }


        public string ListaID_Student { get; set; }

    }
}
