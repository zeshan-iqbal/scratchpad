// See https://aka.ms/new-console-template for more information

using System.Net;

Console.WriteLine("Hello, World!");


var msg = new HttpResponseMessage(HttpStatusCode.OK)
{
    Content = new StringContent(@"{
	'resultCode': 0,
	'message': 'Processed successfully',
	'resultClass': 0,
	'classDescription': '',
	'actionHint': '',
	'requestReference': '6cfb8640-b551-4536-86a4-63db29206b7a',
	'result': {
		'nextActions': 'CAPTURE,REVERSE',
		'transaction': {
			'type': 'AUTHORIZATION',
			'authorizationCode': 'ESPASI',
			'creationTime': '2024-05-08T08:12:19.2210493Z',
			'status': 'SUCCESS',
			'stan': '723732',
			'rrn': '412908723732',
			'id': '7151559395506110104960',
			'amount': 450.0,
			'currency': 'AED'
		},
		'order': {
			'status': 'AUTHORIZED',
			'creationTime': '2024-05-08T08:12:07.767Z',
			'totalAuthorizedAmount': 450.0,
			'totalCapturedAmount': 0.0,
			'totalRefundedAmount': 0.0,
			'totalRemainingAmount': 450.0,
			'totalReversedAmount': 0.0,
			'totalSalesAmount': 0.0,
			'errorCode': 0,
			'id': 412932430851,
			'amount': 450.0,
			'currency': 'AED',
			'name': 'noon Order',
			'reference': 'NMAEB58340V98QN4',
			'category': 'namshi_3ds',
			'channel': 'Web',
			'ipAddress': '9xxxxxxxxx.148'
		},
		'configuration': {
			'tokenizeCc': false,
			'returnUrl': 'https://mp-payment-api-proxy.noon.com/returning/gAAAAABmOzPX1vWALsGQFMYxKWKNs278JkB2Q9LuYjj24Ow9V-gPkHVERGZbY3kIJ2Ow8A-jAW-zUTR66dH0e-I7oEdo6rYdXuhGeHlCbHr2XFC3Kvw7jPQHiwC5jHX_07wEL_XcKVwPpJ1JZ62wwHi5BUJCxba7IfufkVNT0Rxlju6o6EK60m7fuq8l6QieKWljxfai3MPiIjziC0rMwQOQfo7H3OpIiYWZztPIm7Nw8qu-2XJu-XxzoNnCfNKnf2yt7UAfhNQwh6L1AdGl5p07oUAwDiItYci3MxCXVowI1mMLDBBHtgslMMzSgVmrY2Ac800LZKHnfv8pfXptrHTaRJnFU2XxAA==',
			'locale': 'en',
			'paymentAction': 'Authorize, Sale'
		},
		'cvv': {
			'status': 'MATCH'
		},
		'avs': {
			'status': 'NOT_MATCH'
		},
		'fraudCheck': {
			'level1': {
				'status': 'SUCCESS',
				'rules': [
					{
						'ruleName': 'No rule matched',
						'decision': 'ACCEPT'
					}
				]
			},
			'level2': {
				'status': 'SUCCESS',
				'scoreModelUsed': 'default_cemea',
				'suspeciousInfoCode': 'risk-ts',
				'identityInfoCode': 'id-m-nohistory',
				'cardScheme': 'VISA DEBIT',
				'binCountry': 'FR',
				'afsResult': '14',
				'afsFactorCode': 'b',
				'isPreAuth': true,
				'suspeciousInfoCodeList': {
					'risk-ts': ''
				},
				'velocityInfoCodeList': {},
				'hotListInfoCodeList': {},
				'identityInfoCodeList': {
					'id-m-nohistory': ''
				},
				'afsFactorCodeList': {
					'b': 'Card BIN or authorization risk. Risk factors are related to credit card BIN and/or card authorization checks.'
				},
				'profileInfo': {
					'profileSelector': 'Namshi',
					'profileName': 'Namshi Profile',
					'velocityInfoCode': 'GVEL-R6020^GVEL-R6021',
					'rules': [
						{
							'ruleName': 'ID-M-NoHistory',
							'decision': 'IGNORE'
						},
						{
							'ruleName': 'Auto-Accept < 50 Score',
							'decision': 'ACCEPT'
						}
					]
				}
			}
		},
		'payerAuthentication': {
			'enrollment': {
				'status': 'Y',
				'statusDescription': 'CARD_ENROLLED',
				'commerceIndicator': 'vbv',
				'xid': 'AJkBBhNJNQAAAK/IeEEpdQAAAAA=',
				'version': '2.2.0'
			},
			'validation': {
				'cavv': 'AJkBBhNJNQAAAK/IeEEpdQAAAAA=',
				'status': 'Y',
				'statusDescription': 'AUTHENTICATION_SUCCESSFUL',
				'eci': '05',
				'commerceIndicator': 'vbv',
				'xid': 'AJkBBhNJNQAAAK/IeEEpdQAAAAA='
			}
		},
		'paymentDetails': {
			'instrument': 'CARD',
			'tokenIdentifier': 'e45d3718xxxxxxxxxxxxxxxx13f5120475cc',
			'cardAlias': '1e9ab775xxxxxxxxxxxxxxxxfcbbd2ada80c',
			'mode': 'Card',
			'integratorAccount': 'CARD',
			'paymentInfo': '416598xxxxxx4357',
			'brand': 'VISA',
			'scheme': 'VISA',
			'expiryMonth': '11',
			'expiryYear': '2027',
			'isNetworkToken': 'FALSE',
			'cardType': 'DEBIT',
			'cardCategory': 'INFINITE',
			'cardCountry': 'FR',
			'cardCountryName': 'France',
			'cardIssuerName': 'REVOLUT LIMITED'
		}
	}
}")
};


var response = await Utils.ReadResponseAsync<CheckPayerAuthenticationEnrollmentApiResponse>(msg);
Utils.ValidateCheckPayerAuthenticationEnrollmentApiResponse(response, new CheckPayerAuthenticationEnrollmentServiceRequest()
{
	DeviceData = new CheckPayerAuthenticationEnrollmentServiceRequest.DeviceDataModel(),
	IsLive = true,
	OrderId = 412932430851,
	ReturnUrl = "https://example.com"
});