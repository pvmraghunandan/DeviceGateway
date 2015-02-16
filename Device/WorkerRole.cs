// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WorkerRole.cs" company="Microsoft"> 
//   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
//   IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
//   FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
//   THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR 
//   OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
//   ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR 
//   OTHER DEALINGS IN THE SOFTWARE. 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Device
{
    using System.Diagnostics;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.WindowsAzure.ServiceRuntime;
    using Orleans.Runtime.Host;

    /// <summary>
    ///  Worker Role that hosts the Silo.
    /// </summary>
    public class WorkerRole : RoleEntryPoint
    {
        /// <summary>
        /// The silo
        /// </summary>
        private AzureSilo silo;

        /// <summary>
        /// Start the Silo
        /// </summary>
        /// <returns>The Result</returns>
        public override bool OnStart()
        {
            // Set the maximum number of concurrent connections
            ServicePointManager.DefaultConnectionLimit = 12;

            this.silo = new AzureSilo();

            Trace.TraceInformation("Starting Azure Silo");

            return this.silo.Start(RoleEnvironment.DeploymentId, RoleEnvironment.CurrentRoleInstance);
        }

        /// <summary>
        /// Stop the Silo
        /// </summary>
        public override void OnStop()
        {
            Trace.TraceInformation("stopping Silo");
            this.silo.Stop();
        }

        /// <summary>
        /// Runs the Silo.
        /// </summary>
        public override void Run()
        {
            Trace.TraceInformation("Running Azure Silo");
            this.silo.Run();
        }
    }
}
