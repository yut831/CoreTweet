﻿// The MIT License (MIT)
//
// CoreTweet - A .NET Twitter Library supporting Twitter API 1.1
// Copyright (c) 2014 lambdalice
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace CoreTweet.Rest
{
    partial class Help
    {
        //GET Methods

        /// <summary>
        /// <para>Returns the current configuration used by Twitter including twitter.com slugs which are not usernames, maximum photo resolutions, and t.co URL lengths.</para>
        /// <para>It is recommended applications request this endpoint when they are loaded, but no more than once a day.</para>
        /// <para>Avaliable parameters: Nothing.</para>
        /// </summary>
        /// <returns>Configurations.</returns>
        /// <param name='parameters'>
        /// Parameters.
        /// </param>
        public Task<Configurations> ConfigurationAsync(params Expression<Func<string, object>>[] parameters)
        {
            return this.Tokens.AccessApiAsync<Configurations>(MethodType.Get, "help/configuration", parameters);
        }
        public Task<Configurations> ConfigurationAsync(IDictionary<string, object> parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiAsync<Configurations>(MethodType.Get, "help/configuration", parameters, cancellationToken);
        }
        public Task<Configurations> ConfigurationAsync<T>(T parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiAsync<Configurations, T>(MethodType.Get, "help/configuration", parameters, cancellationToken);
        }

        /// <summary>
        /// <para>Returns the list of languages supported by Twitter along with their ISO 639-1 code. The ISO 639-1 code is the two letter value to use if you include lang with any of your requests.</para>
        /// <para>Avaliable parameters: Nothing.</para>
        /// </summary>
        /// <returns>Languages.</returns>
        /// <param name='parameters'>
        /// Parameters.
        /// </param>
        public Task<IEnumerable<Language>> LanguagesAsync(params Expression<Func<string, object>>[] parameters)
        {
            return this.Tokens.AccessApiArrayAsync<Language>(MethodType.Get, "help/languages", parameters);
        }
        public Task<IEnumerable<Language>> LanguagesAsync(IDictionary<string, object> parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiArrayAsync<Language>(MethodType.Get, "help/languages", parameters, cancellationToken);
        }
        public Task<IEnumerable<Language>> LanguagesAsync<T>(T parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiArrayAsync<Language, T>(MethodType.Get, "help/languages", parameters, cancellationToken);
        }

        /// <summary>
        /// <para>Returns Twitter's Privacy Policy.</para>
        /// <para>Avaliable parameters: Nothing.</para>
        /// </summary>
        /// <returns>The sentense.</returns>
        /// <param name='parameters'>
        /// Parameters.
        /// </param>
        public Task<string> PrivacyAsync(params Expression<Func<string, object>>[] parameters)
        {
            return this.Tokens.AccessApiAsync<string>(MethodType.Get, "help/privacy", parameters, "privacy");
        }
        public Task<string> PrivacyAsync(IDictionary<string, object> parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiAsync<string>(MethodType.Get, "help/privacy", parameters, cancellationToken, "privacy");
        }
        public Task<string> PrivacyAsync<T>(T parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiAsync<string, T>(MethodType.Get, "help/privacy", parameters, cancellationToken, "privacy");
        }

        /// <summary>
        /// <para>Returns the Twitter Terms of Service in the requested format. These are not the same as the Developer Rules of the Road.</para>
        /// <para>Avaliable parameters: Nothing.</para>
        /// </summary>
        /// <returns>The sentense.</returns>
        /// <param name='parameters'>
        /// Parameters.
        /// </param>
        public Task<string> TosAsync(params Expression<Func<string, object>>[] parameters)
        {
            return this.Tokens.AccessApiAsync<string>(MethodType.Get, "help/tos", parameters, "tos");
        }
        public Task<string> TosAsync(IDictionary<string, object> parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiAsync<string>(MethodType.Get, "help/tos", parameters, cancellationToken, "tos");
        }
        public Task<string> TosAsync<T>(T parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiAsync<string, T>(MethodType.Get, "help/tos", parameters, cancellationToken, "tos");
        }

        /// <summary>
        /// <para>Returns the current rate limits for methods belonging to the specified resource families.</para>
        /// <para>Avaliable parameters: </para>
        /// <para><paramref name="string, IEnumerable<string> resources (optional)"/> : A list of resource families or comma separated string of ones you want to know the current rate limit disposition for. For best performance, only specify the resource families pertinent to your application.</para>
        /// </summary>
        /// <returns>The dictionary.</returns>
        /// <param name="parameters">
        /// Parameters.
        /// </param>
        public Task<IDictionary<string, IDictionary<string, RateLimit>>> RateLimitStatusAsync(params Expression<Func<string, object>>[] parameters)
        {
            return this.Tokens.AccessApiAsync<IDictionary<string, IDictionary<string, RateLimit>>>(MethodType.Get, "application/rate_limit_status", parameters, "resources");
        }
        public Task<IDictionary<string, IDictionary<string, RateLimit>>> RateLimitStatusAsync(IDictionary<string, object> parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiAsync<IDictionary<string, IDictionary<string, RateLimit>>>(MethodType.Get, "application/rate_limit_status", parameters, cancellationToken, "resources");
        }
        public Task<IDictionary<string, IDictionary<string, RateLimit>>> RateLimitStatusAsync<T>(T parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiAsync<IDictionary<string, IDictionary<string, RateLimit>>, T>(MethodType.Get, "application/rate_limit_status", parameters, cancellationToken, "resources");
        }
    }
}
