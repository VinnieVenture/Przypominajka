// Copyright © 2017-2020 Chromely Projects. All rights reserved.
// Use of this source code is governed by MIT license that can be found in the LICENSE file.

using System.Collections.Generic;
using System.Web.Mvc;
using Chromely;
using Chromely.Core;
using Chromely.Core.Configuration;
using Chromely.Core.Network;
using Przypominajka.Core;
using Przypominajka.Core.Interfaces;

namespace ChromelyAngular.Controllers
{
    /// <summary>
    /// The demo controller.
    /// </summary>
    [Route("api/[controller]")]
    [ControllerProperty(Name = "controller")]
    public class Controller : ChromelyController
    {
        private readonly IChromelyConfiguration _config;
        private readonly IChromelySerializerUtil _serializerUtil;

        private IRequestManager RequestManager;
        /// <summary>
        /// Initializes a new instance of the <see cref="Controller"/> class.
        /// </summary>
        public Controller(IChromelyConfiguration config, IChromelySerializerUtil serializerUtil)
        {
            this.RequestManager = new RequestsManager(Przypominajka.Core.Enums.DataLoadingTypes.Serialization);

            _config = config;
            _serializerUtil = serializerUtil;

            RegisterRequest("/controller/alarms/getAlarms", GetAlarms);
            //RegisterRequest("/controller/alarms/post", NaraziePustaMetoda);
        }

        #region CommandAttributes

        [CommandAction(RouteKey = "/controller/showdevtools")]
        public void ShowDevTools(IDictionary<string, string> queryParameters)
        {
            if (_config != null && !string.IsNullOrWhiteSpace(_config.DevToolsUrl))
            {
                BrowserLauncher.Open(_config.Platform, _config.DevToolsUrl);
            }
        }

        #endregion
        [HttpGet]
        public IChromelyResponse GetAlarms(IChromelyRequest request)
        {
            return new ChromelyResponse(request.Id)
            {
                Data = RequestManager.ReadAll()
            };
        }

        //private IChromelyResponse NaraziePustaMetoda(IChromelyRequest request)
        //{
        //    if (request == null)
        //    {
        //        throw new ArgumentNullException(nameof(request));
        //    }

        //    if (request.PostData == null)
        //    {
        //        throw new Exception("Post data is null or invalid.");
        //    }

        //    var response = new ChromelyResponse(request.Id);
        //    var postDataJson = _serializerUtil.ObjectToJson(request.PostData);

        //    var options = new JsonSerializerOptions();
        //    options.ReadCommentHandling = JsonCommentHandling.Skip;
        //    options.AllowTrailingCommas = true;
        //    var movies = JsonSerializer.Deserialize<List<MovieInfo>>(postDataJson, options);
        //    var rowsReceived = movies != null ? movies.Count : 0;
        //    response.Data = $"{DateTime.Now}: {rowsReceived} rows of data successfully saved.";

        //    return response;
        //}
    }
}
