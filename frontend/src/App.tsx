import { useEffect, useState } from "react";
import { IPortkeyProvider, MethodsBase } from "@portkey/provider-types";
import detectProvider from "@portkey/detect-provider";
import "./App.css";
import SmartContract from "./SmartContract";

function App() {
  const [provider, setProvider] = useState<IPortkeyProvider | null>(null);
  const [isConnected, setIsConnected] = useState(false);

  const init = async () => {
    try {
      setProvider(await detectProvider());
    } catch (error) {
      console.log(error, "=====error");
    }
  };

  const connect = async () => {
    try {
      await provider?.request({
        method: MethodsBase.REQUEST_ACCOUNTS,
      });
      setIsConnected(true);
    } catch (error) {
      console.error("Error connecting wallet:", error);
      setIsConnected(false);
    }
  };

  useEffect(() => {
    if (!provider) init();
  }, [provider]);

  if (!provider) return <>Wallet not Found.</>;

  return (
    <>
      <div className="row app">
        <div className="col-12">
        <div className="nav-bar mt-1 d-flex justify-content-between">
          <h1 className="project-title">NFT Project</h1>
          {isConnected ? (
            <span className="connected-text wallet-btn connected">Connected</span>
          ) : (
            <button className="wallet-btn" onClick={connect}>
              Connect Wallet
            </button>
          )}
        </div>
          <SmartContract provider={provider} />
        </div>
      </div>
    </>
  );
}

export default App;