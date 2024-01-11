import React from "react";
import { IPortkeyProvider, MethodsBase } from "@portkey/provider-types";
import useSmartContract from "./useSmartContract";
import { useState } from "react";
import ShowModal from "./ShowModal.tsx";
import { Scrollbars } from "react-custom-scrollbars-2";
import AElf from "aelf-sdk";
import { GetBalanceInput } from "aelf-sdk";

const aelf = new AElf(new AElf.providers.HttpProvider("http://127.0.0.1:8000"));

interface Description {
  description: string;
}

function NFTProject({ provider }: { provider: IPortkeyProvider | null }) {
  const [input, setInput] = useState("");
  const [description, setDescription] = useState<Description[]>([]);
  const [modal, setModal] = useState(false);
  const smartContract = useSmartContract(provider);

  const handleChange = (e: React.ChangeEvent<HTMLTextAreaElement>) => {
    setInput(e.target.value);
  };

  const handleSubmit = async (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();

    try {
      if (!provider) {
        throw new Error("No provider");
      }

      const accounts = await provider?.request({
        method: MethodsBase.ACCOUNTS,
      });

      if (!accounts || !accounts.length) {
        throw new Error("No accounts");
      }

      const account = accounts[0];

      if (!account) {
        throw new Error("No account");
      }

      const createInput = {
        Symbol: "NFT", // Replace with the actual symbol
        Owner: account,
        Issuer: account,
      };

      const result = await smartContract?.Create(createInput);

      console.log("NFT Created successfully!", result);
    } catch (error) {
      console.error("Error creating NFT:", error);
    }

    setDescription([...description, { description: input }]);
    setInput("");
  };

  const openModal = () => {
    setModal(true);
  };

  const closeModal = () => {
    setModal(false);
  };

  return (
    <>
      <div className="row">
        <div className="col-md-6 d-flex justify-content-center align-content-center mt-5">
          <div className="card">
            <div className="card-body z-1">
              <h5 className="card-title">
                Share your traveling experience here!
              </h5>
              <form onSubmit={handleSubmit}>
                <div className="mb-1">
                  <div className="p-1">
                    <textarea
                      value={input}
                      style={{ height: "150px", width: "100%" }}
                      onChange={handleChange}
                    ></textarea>
                  </div>
                </div>
                <button type="submit" className="submit-btn">
                  Submit
                </button>
              </form>
            </div>
          </div>
        </div>
        <div className="col-md-6 d-flex justify-content-center align-items-center">
          <div className="table-div p-4 mt-5">
            <Scrollbars
              autoHeight
              autoHeightMin={100}
              autoHeightMax={280}
              thumbMinSize={100}
              thumbSize={280}
              style={{ width: "100%" }}
              renderThumbVertical={({ style, ...props }) => (
                <div
                  {...props}
                  style={{
                    ...style,
                    borderRadius: "5px",
                    backgroundColor: "#bbb",
                    opacity: "0.75",
                    width: "7px",
                    marginTop: "50px",
                  }}
                />
              )}
            >
              <table className="table">
                <thead>
                  <tr>
                    <th scope="col">Sr.</th>
                    <th scope="col">Post's Description</th>
                  </tr>
                </thead>
                {description.map((currElem, index) => (
                  <tbody key={index}>
                    <tr>
                      <th scope="row">{index}</th>
                      <td>
                        <div className="d-flex  justify-content-between">
                          <div>{currElem.description}</div>
                          <button onClick={openModal} className="v-btn">
                            View
                          </button>
                          {modal && (
                            <ShowModal
                              description={currElem.description}
                              closeModal={closeModal}
                            />
                          )}
                        </div>
                      </td>
                    </tr>
                  </tbody>
                ))}
              </table>
            </Scrollbars>
          </div>
        </div>
      </div>
    </>
  );
}

export default NFTProject;
