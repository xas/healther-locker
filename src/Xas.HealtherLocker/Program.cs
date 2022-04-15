// SPDX-License-Identifier: GPL-3.0-or-later

using (HttpClient client = new HttpClient())
{
    try
    {
        var response = await client.GetAsync(new Uri(args[0]));
        return response.IsSuccessStatusCode ? 0 : 1;
    }
    catch
    {
        return 1;
    }
}