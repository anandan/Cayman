﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
using BlitsMe.Agent.Components.Search;
using BlitsMe.Agent.UI.WPF.Engage;
using BlitsMe.Agent.UI.WPF.Utils;

namespace BlitsMe.Agent.UI.WPF.Search
{
    class SearchResultControlList : ObservableListMirror<SearchResult,SearchResultControl>
    {
        private BlitsMeClientAppContext _appContext;
        private SearchResult _sourceObject;

        public SearchResultControlList(BlitsMeClientAppContext appContext, Dispatcher dispatcher)
            : base(dispatcher)
        {
            _appContext = appContext;
        }


        protected override SearchResultControl CreateNew(SearchResult sourceObject)
        {
            _sourceObject = sourceObject;
            return new SearchResultControl(_appContext, sourceObject);
        }
        
    }
}
