// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeviceGrain.cs" company="Microsoft"> 
//   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
//   IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
//   FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
//   THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR 
//   OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
//   ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR 
//   OTHER DEALINGS IN THE SOFTWARE. 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DeviceImplementation
{
    using System.Diagnostics;
    using System.Threading.Tasks;
    using DeviceInterfaces;
    using Orleans;

    /// <summary>
    /// Simulates the Device
    /// </summary>
    public class DeviceGrain : Grain, IDeviceGrain
    {
        /// <summary>
        /// The last data
        /// </summary>
        private string lastData;

        /// <summary>
        /// Processes the telemetry data.
        /// </summary>
        /// <param name="data">The telemetry data.</param>
        /// <returns>The Task</returns>
        public Task ProcessData(string data)
        {
            string sample;
            this.GetPrimaryKeyLong(out sample);
            Debug.WriteLine(sample + ": " + data);
            this.lastData = data;
            return TaskDone.Done;
        }
    }
}