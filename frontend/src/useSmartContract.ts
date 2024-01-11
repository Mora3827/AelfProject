import { IPortkeyProvider, IChain } from "@portkey/provider-types";
import { useEffect, useState } from "react";

function useSmartContract(provider: IPortkeyProvider | null) {
  const [smartContract, setSmartContract] = useState<any>(null);

  useEffect(() => {
    (async () => {
      if (!provider) return null;

      try {
        // 1. get the sidechain tDVW using provider.getChain
        const chain = await provider?.getChain("tDVW");
        if (!chain) throw new Error("No chain");

        // 2. get the NFT contract
        const nftContract = chain?.getContract("ASh2Wt7nSEmYqnGxPPzp4pnVDU4uhj1XW9Se5VeZcX2UDdyjx");
        setSmartContract(nftContract);
      } catch (error) {
        console.log(error, "====error");
      }
    })();
  }, [provider]);

  return smartContract;
}

export default useSmartContract;

