﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using stellar_dotnetcore_sdk.responses.operations;

namespace stellar_dotnetcore_sdk.responses
{
    public class OperationDeserializer : JsonConverter
    {
        private Type[] operationResponseTypes = new[]
        {
            typeof(CreateAccountOperation)
        };

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var type = jsonObject.GetValue("type_i").ToObject<int>();

            switch (type)
            {
                case 0:
                    return JsonSingleton.GetInstance<CreateAccountOperationResponse>(jsonObject.Root.ToString());
                //case 1:
                //    return gson.fromJson(json, PaymentOperationResponse.class);
                //case 2:
                //    return gson.fromJson(json, PathPaymentOperationResponse.class);
                //case 3:
                //    return gson.fromJson(json, ManageOfferOperationResponse.class);
                //case 4:
                //    return gson.fromJson(json, CreatePassiveOfferOperationResponse.class);
                //case 5:
                //    return gson.fromJson(json, SetOptionsOperationResponse.class);
                //case 6:
                //    return gson.fromJson(json, ChangeTrustOperationResponse.class);
                //case 7:
                //    return gson.fromJson(json, AllowTrustOperationResponse.class);
                //case 8:
                //    return gson.fromJson(json, AccountMergeOperationResponse.class);
                //case 9:
                //    return gson.fromJson(json, InflationOperationResponse.class);
                //case 10:
                //    return gson.fromJson(json, ManageDataOperationResponse.class);
                default:
                    throw new Exception("Invalid operation type");
            }
}

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(OperationResponse);
        }
    }
}