// ShowModal.tsx
import React, { useState } from "react";
import {
  AiOutlineLike,
  AiOutlineDislike,
  AiFillLike,
  AiFillDislike,
} from "react-icons/ai";
import { BiHeart } from "react-icons/bi";

interface ShowModalProps {
  description: string;
  closeModal: () => void;
}

const ShowModal: React.FC<ShowModalProps> = ({ description, closeModal }) => {
  const [liked, setLiked] = useState<boolean>(false);
  const [disliked, setDisliked] = useState<boolean>(false);

  const toggleLike = () => {
    setLiked(!liked);
    if (disliked) setDisliked(false);
  };

  const toggleDislike = () => {
    setDisliked(!disliked);
    if (liked) setLiked(false);
  };

  return (
    <>
      <div
        onClick={() => {
          closeModal();
        }}
        className="modal-wrapper"
      ></div>
      <div className="modal-container p-2 pb-5">
        <div className="img-div d-flex flex-row justify-content-between"></div>

        <div className="">
          <div className="data-div">
            <p>{description}</p>
          </div>
        </div>
        <div className="d-flex">
          <button className={`reaction-btn ${liked ? "active" : ""}`} onClick={toggleLike}>
            {liked ? <AiFillLike /> : <AiOutlineLike />}
          </button>
          <button className={`reaction-btn ${disliked ? "active" : ""}`} onClick={toggleDislike}>
            {disliked ? <AiFillDislike /> : <AiOutlineDislike />}
          </button>
          <button className="reaction-btn">
            <BiHeart />
          </button>
        </div>
      </div>
    </>
  );
};

export default ShowModal;
