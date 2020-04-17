class ErrCode
{
	public static string errMsg(uint nErrCode)
	{
		string text = "";
		switch (nErrCode)
		{
			case 2148532225u:
				return "An internal consistency check failed.";
			case 2148532226u:
				return "The action was canceled by a SCardCancel request.";
			case 2148532227u:
				return "The supplied handle was invalid.";
			case 2148532228u:
				return "One or more of the supplied parameters could not be properly interpreted.";
			case 2148532229u:
				return "Registry startup information is missing or invalid.";
			case 2148532230u:
				return "Not enough memory available to complete this command.";
			case 2148532231u:
				return "An internal consistency timer has expired.";
			case 2148532232u:
				return "The data buffer to receive returned data is too small for the returned data.";
			case 2148532233u:
				return "The specified reader name is not recognized.";
			case 2148532234u:
				return "The user-specified timeout value has expired.";
			case 2148532235u:
				return "The smart card cannot be accessed because of other connections outstanding.";
			case 2148532236u:
				return "未插入健保IC卡";
			case 2148532237u:
				return "The specified smart card name is not recognized.";
			case 2148532238u:
				return "The system could not dispose of the media in the requested manner.";
			case 2148532239u:
				return "The requested protocols are incompatible with the protocol currently in use with the smart card.";
			case 2148532240u:
				return "The reader or smart card is not ready to accept commands.";
			case 2148532241u:
				return "One or more of the supplied parameters values could not be properly interpreted.";
			case 2148532242u:
				return "The action was canceled by the system, presumably to log off or shut down.";
			case 2148532243u:
				return "An internal communications error has been detected.";
			case 2148532244u:
				return "An internal error has been detected, but the source is unknown.";
			case 2148532245u:
				return "An ATR obtained from the registry is not a valid ATR string.";
			case 2148532246u:
				return "An attempt was made to end a non-existent transaction.";
			case 2148532247u:
				return "The specified reader is not currently available for use.";
			case 2148532248u:
				return "The operation has been aborted to allow the server application to exit.";
			case 2148532249u:
				return "The PCI Receive buffer was too small.";
			case 2148532250u:
				return "The reader driver does not meet minimal requirements for support.";
			case 2148532251u:
				return "The reader driver did not produce a unique reader name.";
			case 2148532252u:
				return "The smart card does not meet minimal requirements for support.";
			case 2148532253u:
				return "The Smart Card Resource Manager is not running.";
			case 2148532254u:
				return "The Smart Card Resource Manager has shut down.";
			case 2148532255u:
				return "An unexpected card error has occured.";
			case 2148532256u:
				return "No primary provider can be found for the smart card.";
			case 2148532257u:
				return "The requested order of object creation is not supported.";
			case 2148532258u:
				return "This smart card does not support the requested feature.";
			case 2148532259u:
				return "The identified directory does not exist in the smart card.";
			case 2148532260u:
				return "The identified file does not exist in the smart card.";
			case 2148532261u:
				return "The supplied path does not represent a smart card directory.";
			case 2148532262u:
				return "The supplied path does not represent a smart card file.";
			case 2148532263u:
				return "Access is denied to this file.";
			case 2148532264u:
				return "The smart card does not have enough memory to store the information.";
			case 2148532265u:
				return "There was an error trying to set the smart card file object pointer.";
			case 2148532266u:
				return "The supplied PIN is incorrect.";
			case 2148532267u:
				return "An unrecognized error code was returned from a layered component.";
			case 2148532268u:
				return "The requested certificate does not exist.";
			case 2148532269u:
				return "The requested certificate could not be obtained.";
			case 2148532270u:
				return "請接上讀卡機裝置";
			case 2148532271u:
				return "A communications error with the smart card has been detected. Retry the operation.";
			case 2148532272u:
				return "The requested key container does not exist on the smart card.";
			case 2148532273u:
				return "The Smart Card Resource Manager is too busy to complete this operation.";
			case 2148532325u:
				return "The reader cannot communiate with the card, due to ATR string configuration conflicts.";
			case 2148532326u:
				return "請確認卡片類別，並重新插卡";
			case 2148532327u:
				return "Power has been removed from the smart card, so that further communication is not possible.";
			case 2148532328u:
				return "The msart card has been reset, so any shared state information is invalid.";
			case 2148532329u:
				return "未插入健保IC卡";
			case 2148532330u:
				return "Access was denied because of a security violation.";
			case 2148532331u:
				return "The card cannot be accessed because th wrong PIN was presented.";
			case 2148532332u:
				return "The card cannot be accessed because the maximum number of PIN entry attempts has been reached.";
			case 2148532333u:
				return "The end of the smart card file has been reached.";
			case 2148532334u:
				return "The action was canceled by the user.";
			case 2148532335u:
				return "No PIN was presented to the smart card.";
			default:
				return "錯誤代碼" + nErrCode;
		}
	}
}
