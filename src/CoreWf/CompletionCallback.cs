// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace CoreWf
{
    public delegate void CompletionCallback(NativeActivityContext context, ActivityInstance completedInstance);
    public delegate void CompletionCallback<TResult>(NativeActivityContext context, ActivityInstance completedInstance, TResult result);
}
